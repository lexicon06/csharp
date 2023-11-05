<?php

ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);

// Include the Zip class
class Zip
{
    public static function Compress($data)
    {
        return gzcompress($data);
    }

    public static function Decompress($data)
    {
        return gzuncompress($data);
    }
}

class Program
{
    public static function Main()
    {
        $room = self::DecodeHashlink("arlnk://F5fPZROCs4iuoc9Jm55ZbaOFmNlWiMGfo6mdC6eQOPjF/B/AfHuXAbhqNmb1T7HX2fuO");
        echo "Name: {$room['Name']}, IP: {$room['IP']}, Port: {$room['Port']}\n";
    }

    private static function DecodeHashlink($hashlink)
    {
        // Remove the "arlnk://" prefix and decode the base64 string
        $base64 = substr($hashlink, 8);
        $data = base64_decode($base64);

        // Decrypt the data using the d67 method
        $data = self::d67($data, 28435);

        // Decompress the data using Zip::Decompress method from Zip class
        $data = Zip::Decompress($data);

        // Parse the decrypted data into a DecryptedHashlink object
        $reader = new HashlinkReader($data);
        $reader->SkipBytes(32);
        $room = array();

        $room['IP'] = $reader->toIP();
        $room['Port'] = $reader->toPort();
        $reader->SkipBytes(4);
        $room['Name'] = $reader->toString();

        return $room;
    }

    private static function d67($data, $b)
    {
        $buffer = $data;

        for ($i = 0; $i < strlen($data); $i++)
        {
            $buffer[$i] = chr(ord($data[$i]) ^ $b >> 8 & 255);
            $b = ($b + ord($data[$i])) * 23219 + 36126 & 65535;
        }

        return $buffer;
    }
}

class HashlinkReader
{
    private $Position = 0;
    private $Data = array();

    public function __construct($bytes)
    {
        $this->Data = array_values(unpack('C*', $bytes));
        $this->Position = 0;
    }

    public function SkipBytes($count)
    {
        $this->Position += $count;
    }

    public function toString()
    {
        $split = array_search(0, array_slice($this->Data, $this->Position));
        $tmp = array_slice($this->Data, $this->Position, $split !== false ? $split : null);
        $this->Position += $split !== false ? $split + 1 : count($tmp);
        return implode('', array_map('chr', $tmp));
    }

    public function toPort()
    {
        $tmp = array_slice($this->Data, $this->Position, 2);
        $this->Position += 2;
        $tmp = implode(array_map("chr", $tmp)); // Convert byte array back to string
        return unpack("n", $tmp)[1];
    }



    public function toIP()
    {
        $tmp = array_slice($this->Data, $this->Position, 4);
        $this->Position += 4;
        return implode('.', $tmp);
    }
}


Program::Main();
?>
