﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowcrashCLR.tests {
    public static class source {
        public const string API = @"
FORMAT: X-1A

# The Simplest API
This is one of the simplest APIs written in the **API Blueprint**. 
One plain resource combined with a method and that's it! We will explain what is going on in the next installment - [Resource and Actions](2.%20Resource%20and%20Actions.md).

**Note:** As we progress through the examples, do not also forget to view the [Raw](https://raw.github.com/apiaryio/api-blueprint/master/examples/1.%20Simplest%20API.md) code to see what is really going on in the API Blueprint, as opposed to just seeing the output of the Github Markdown parser. 

Also please keep in mind that every single example in this tutorial is a **real API Blueprint** and as such you can **parse** it with the [API Blueprint parser](https://github.com/apiaryio/snowcrash) or one of its [bindings](https://github.com/apiaryio/snowcrash#bindings).

Visit the [Glossary of Terms](https://github.com/apiaryio/api-blueprint/blob/master/Glossary%20of%20Terms.md) for the explanation of some basic terms used througout this tutorial.

## API Blueprint Tutorial
+ [This: Raw API Blueprint](https://raw.github.com/apiaryio/api-blueprint/master/examples/1.%20Simplest%20API.md)
+ [Next: Resource and Actions](2.%20Resource%20and%20Actions.md)

# GET /message
+ Response 200 (text/plain)    
        Hello World!
        ";
    }
}
