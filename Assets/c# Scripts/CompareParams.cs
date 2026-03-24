using UnityEngine;
using UnityEngine.UI;

public class CompareParams : MonoBehaviour
{
    public Text text_compare_socket;
    public Text text_compare_power;
    public Text text_compare_tdp;

    void Update()
    {
        Compare();
    }

    public void Compare()
    {
        string motherParam = PlayerPrefs.GetString("Mother");
        string cpuParam = PlayerPrefs.GetString("CPU");

        // Получаем числовые параметры напрямую как int
        int gpuPowerReq = PlayerPrefs.GetInt("GPU", 0);  // 0 - значение по умолчанию, если ключа нет
        int powerSupplyWattage = PlayerPrefs.GetInt("Power", 0);
        int coolerTDP = PlayerPrefs.GetInt("Cooler", 0);
        int cpuTDP = PlayerPrefs.GetInt("TDP", 0);

        // Сравнение сокетов
        if (motherParam == cpuParam)
        {
            text_compare_socket.text = "Параметры Mother и CPU совместимы.";
        }
        else
        {
            text_compare_socket.text = "Параметры Mother и CPU не совместимы!";
        }

        // Проверка мощности БП
        if (powerSupplyWattage >= gpuPowerReq)
        {
            text_compare_power.text = "Блок питания подходит.";
        }
        else
        {
            text_compare_power.text = "Блок питания слишком слабый!";
        }

        // Проверка кулера
        if (coolerTDP >= cpuTDP)
        {
            text_compare_tdp.text = "Кулер справится с охлаждением.";
        }
        else
        {
            text_compare_tdp.text = "Кулер недостаточно мощный!";
        }
    }
}