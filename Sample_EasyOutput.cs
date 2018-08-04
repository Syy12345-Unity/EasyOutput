using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Syy.Sample {

    public class Sample_EasyOutput : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            EasyOutput.Clear();
            EasyOutput.Append("append1");
            EasyOutput.Append("append2");
            EasyOutput.Append("append3");
            EasyOutput.AppendLine("appendLine1");
            EasyOutput.AppendLine("appendLine2");
            EasyOutput.AppendLine("appendLine3");
            EasyOutput.AppendFormat("message {0}","AppendFormat1");
            EasyOutput.AppendFormat("message {0}", "AppendFormat2");
            EasyOutput.AppendFormat("message {0}", "AppendFormat3");
            EasyOutput.AppendFormatLine("message {0}", "AppendFormatLine1");
            EasyOutput.AppendFormatLine("message {0}", "AppendFormatLine2");
            EasyOutput.AppendFormatLine("message {0}", "AppendFormatLine3");
            EasyOutput.Output();
        }
    }

}
