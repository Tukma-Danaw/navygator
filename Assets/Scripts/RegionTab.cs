using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegionTab : MonoBehaviour
{
    public Dropdown RegionList;
    public Text Incident;
    public Text Timestamp;
    public Text RegionLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Ilocos()
    {
        RegionList.value = 0;
        Incident.text = "Endangered Fishing";
        Timestamp.text = "August 21, 2020 14:02";
        RegionLocation.text = "Ilocos Region";
    }

    public void CagayanValley()
    {
        RegionList.value = 1;
        Incident.text = "Dynamite Fishing";
        Timestamp.text = "August 17, 2020 15:05";
        RegionLocation.text = "Cagayan Valley";
    }

    public void CentralLuzon()
    {
        RegionList.value = 2;
        Incident.text = "Endangered Fishing";
        Timestamp.text = "August 18, 2020 17:01";
        RegionLocation.text = "Central Luzon";
    }

    public void Calabarzon()
    {
        RegionList.value = 3;
        Incident.text = "Dynamite Fishing";
        Timestamp.text = "August 17, 2020 16:10";
        RegionLocation.text = "Calabarzon";
    }

    public void Mimaropa()
    {
        RegionList.value = 4;
        Incident.text = "Unlicensed Fishing";
        Timestamp.text = "August 12, 2020 15:52";
        RegionLocation.text = "Mimaropa";
    }

    public void Bicol()
    {
        RegionList.value = 5;
        Incident.text = "Endangered Fishing";
        Timestamp.text = "August 23, 2020 16:35";
        RegionLocation.text = "Bicol Region";
    }

    public void WesternVisayas()
    {
        RegionList.value = 6;
        Incident.text = "Endangered Fishing";
        Timestamp.text = "August 12, 2020 17:08";
        RegionLocation.text = "Western Visayas";
    }

    public void CentralVisayas()
    {
        RegionList.value = 7;
        Incident.text = "Excessive Fishing";
        Timestamp.text = "August 11, 2020 14:53";
        RegionLocation.text = "Central Visayas";
    }

    public void EasternVisayas()
    {
        RegionList.value = 8;
        Incident.text = "Excessive Fishing";
        Timestamp.text = "August 24, 2020 14:48";
        RegionLocation.text = "Eastern Visayas";
    }

    public void Zamboanga()
    {
        RegionList.value = 9;
        Incident.text = "Endangered Fishing";
        Timestamp.text = "August 14, 2020 17:23";
        RegionLocation.text = "Zamboanga Peninsula";
    }

    public void NorthernMindanao()
    {
        RegionList.value = 10;
        Incident.text = "Unlicensed Fishing";
        Timestamp.text = "August 15, 2020 15:34";
        RegionLocation.text = "Northern Mindanao";
    }

    public void Davao()
    {
        RegionList.value = 11;
        Incident.text = "Unlicensed Fishing";
        Timestamp.text = "August 15, 2020 16:12";
        RegionLocation.text = "Davao Region";
    }

    public void Soccksargen()
    {
        RegionList.value = 12;
        Incident.text = "Endangered Fishing";
        Timestamp.text = "August 17, 2020 14:42";
        RegionLocation.text = "Soccksargen";
    }

    public void BARMM()
    {
        RegionList.value = 13;
        Incident.text = "Excessive Fishing";
        Timestamp.text = "August 14, 2020 16:32";
        RegionLocation.text = "BARMM";
    }

    public void NCR()
    {
        RegionList.value = 14;
        Incident.text = "Endangered Fishing";
        Timestamp.text = "August 23, 2020 14:33";
        RegionLocation.text = "NCR";
    }

    public void CAR()
    {
        RegionList.value = 15;
        Incident.text = "Endangered Fishing";
        Timestamp.text = "August 12, 2020 13:56";
        RegionLocation.text = "CAR";
    }

    public void WestPH()
    {
        RegionList.value = 16;
        Incident.text = "Dynamite Fishing";
        Timestamp.text = "August 20, 2020 15:49";
        RegionLocation.text = "West Philippine Sea";
    }

    public void PH()
    {
        RegionList.value = 17;
        Incident.text = "Endangered Fishing";
        Timestamp.text = "August 23, 2020 14:42";
        RegionLocation.text = "Philippine Sea";
    }

    public void Sulu()
    {
        RegionList.value = 18;
        Incident.text = "Dynamite Fishing";
        Timestamp.text = "August 22, 2020 13:49";
        RegionLocation.text = "Sulu Sea";
    }

    public void Celebes()
    {
        RegionList.value = 19;
        Incident.text = "Endangered Fishing";
        Timestamp.text = "August 23, 2020 16:02";
        RegionLocation.text = "Celebes Sea";
    }
}
