using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Interpreter
{
    public class Context
    {
        // Any global information needed for interpretation
        // For our simple calculator example, we don't currently need context.
        // But, say we wanted to interpret English to Spanish. Spanish-speaking countries speak Spanish slightly differently. So the context could contain the country and city that we are located in. It could also keep the gender of the person we are speaking to, as that could also affect the interpretation.
    }
}