using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;

public class MyConfig
{
    private const string ConfigFileName = "MyData";
    private bool IsDataSet;

    private string ConfigFilePath
    {
        get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigFileName); }
    }

    // 키값을 입력받아 해당 키 값에 데이터 저장하는 함수
    public void SetData (string dataName, string value)
    {
        EnsureConfigFileExists();
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigFilePath);

        // Check if the setting already exists, and remove it if needed
        if (config.AppSettings.Settings[dataName] != null)
        {
            config.AppSettings.Settings.Remove(dataName);
        }

        // Add the new setting with the user input
        config.AppSettings.Settings.Add(dataName, value);

        // Save the changes
        config.Save(ConfigurationSaveMode.Modified);

        // Force a reload of the configuration file
        ConfigurationManager.RefreshSection("appSettings");

        IsDataSet = true;
    }

    //키 값을 입력받아 해당 키값의 데이터를 불러오는 함수
    public string getData (string dataName)
    {
        EnsureConfigFileExists();
        Debug.WriteLine(ConfigFilePath);
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigFilePath);
        //return ConfigurationManager.AppSettings[dataName];
        // Ensure that the key exists in the configuration
        string data = "";
        try
        {
            data = config.AppSettings.Settings[dataName].Value;
        } catch(Exception ex) {
            Debug.WriteLine(ex);
        }

        if (data != "")
            {
                return data;
                //return ConfigurationManager.AppSettings[dataName];
            }
            else
            {
             //   Debug.WriteLine($"Key '{dataName}' not found in configuration.");
                return "no such data exist";
            }
        }
  

    // config파일 존재 확인
    private bool EnsureConfigFileExists()
    {
        if (!File.Exists(ConfigFilePath))
        {
            // Create a new configuration file with default content
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = ConfigFilePath;

            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            config.Save(ConfigurationSaveMode.Full, true);

            return true;
        }
        else
        {
            return false;
        }
    }
}