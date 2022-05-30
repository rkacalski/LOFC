using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pilotLists : MonoBehaviour
{
    public Dictionary<string, string> slave1 = new Dictionary<string, string>
    {
        { "bFett[TRH]_5star", "SS" },
        { "jFett_4star", "S" },
        { "aSing_2star", "A" },
        { "dVader_2star", "B" },
        { "aKolar_2star", "C" },
        { "dVader[TA]_5star", "D" },
        //remove after testing
        { "asecura_1star", "D" },
        { "stormtrooper_1star", "SS" },
        { "nebit_1star", "A" },
    };

    public Dictionary<string, string> slave1co = new Dictionary<string, string>
    {
        { "bFett[TRH]_5star", "S" },
        { "jFett_4star", "S" },
        { "aSing_2star", "A" },
        { "dVader_2star", "B" },
        { "aKolar_2star", "C" },
        { "dVader[TA]_5star", "D" },
        //remove after testing
        { "asecura_1star", "D" },
        { "stormtrooper_1star", "S" },
        { "nebit_1star", "A" },
    };
}
