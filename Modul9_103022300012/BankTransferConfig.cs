using System;
using System.Collections.Generic;
using System.Text.Json;

public class BankTransferConfig
{
    public string lang { get; set; } = "en";
    public int threshold { get; set; } = 25000000;
    public int lower_fee { get; set; } = 6500;
    public int upper_fee { get; set; }  = 15000;
    public string[] methods { get; set; } = ["RTO(real - time)", "SKN", "RTGS", "BI FAST"];
    public string en { get; set; } = "yes";
    public string id { get; set; } = "ya";

    public static BankTransferConfig LoadConfig()
    {
        String filePath = "bank_transfer_config.json";

        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            BankTransferConfig config = JsonSerializer.Deserialize<BankTransferConfig>(jsonString);
            return config;
        }
        else
        {
            Console.WriteLine("Configuration file not found. Using default values.");
            return new BankTransferConfig();
        }
    }
}

