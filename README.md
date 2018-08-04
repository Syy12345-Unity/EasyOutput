# EasyOutput
Output to text file or Unity Console (Unity Editor only)

# Feature
* Output to text file (Assets/*)
* Output to Unity Console

# Usage
First, execute the Clear function. Next, execute the Append function, and finally execute the Output function.

```C#:Sample_EasyOutput
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

```

## Output
```Output.txt

append1append2append3appendLine1
appendLine2
appendLine3
message AppendFormat1message AppendFormat2message AppendFormat3message AppendFormatLine1
message AppendFormatLine2
message AppendFormatLine3

```

## Licence

[MIT](https://github.com/tcnksm/tool/blob/master/LICENCE)

## Author

[Syy12345-Unity](https://github.com/Syy12345-Unity)
