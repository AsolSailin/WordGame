using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Core
{
    public class Question
    {
#nullable enable
        public string? Id { get; set; }
        public string? Description { get; set; }
        public string? Answer { get; set; }
#nullable disable
    }
}
