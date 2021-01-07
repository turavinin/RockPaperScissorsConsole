using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLibrary
{
    public class ComputerInfoModel
    {
        public string ComputerName { get; set; } = "Alien";
        public string ComputerSelection { get; set; } = GameLogic.ComputerSelection();

    }
}
