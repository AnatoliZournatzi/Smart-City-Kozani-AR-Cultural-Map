using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void arxaiologiki()
    {
        Application.OpenURL("https://cityofkozani.gov.gr/archaiologiko-mouseio-kozanes");
    }

    public void dimotiki_xartothiki()
    {
        Application.OpenURL("http://cartography.web.auth.gr/Kozani/index.htm");
    }

    public void istoriko()
    {
        Application.OpenURL("https://mouseio-kozanis.gr/");
    }

    public void mouseio_sigxr_topikis()
    {
        Application.OpenURL("https://cityofkozani.gov.gr/mouseio-synchrones-topikes-istorias");
    }

    public void koventarios()
    {
        Application.OpenURL("http://www.kozlib.gr/kozlib_new/?lang=en");
    }

    public void odeio()
    {
        Application.OpenURL("https://cityofkozani.gov.gr/mousike-paideia");
    }

    public void dipethe()
    {
        Application.OpenURL("https://www.dipethekozanis.gr/");
    }

    public void kodonostasio()
    {
        Application.OpenURL("http://agiosnikolaoskozanis.gr/%ce%ba%cf%89%ce%b4%cf%89%ce%bd%ce%bf%cf%83%cf%84%ce%ac%cf%83%ce%b9%ce%bf/");
    }

    public void agios_nikolaos()
    {
        Application.OpenURL("http://agiosnikolaoskozanis.gr/%ce%b9%cf%83%cf%84%ce%bf%cf%81%ce%af%ce%b1-%cf%84%ce%bf%cf%85-%ce%bd%ce%b1%ce%bf%cf%8d/");
    }

    public void plateia_nikis()
    {
        Application.OpenURL("https://el.wikipedia.org/wiki/%CE%A0%CE%BB%CE%B1%CF%84%CE%B5%CE%AF%CE%B1_%CE%9D%CE%AF%CE%BA%CE%B7%CF%82");
    }
}
