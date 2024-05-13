using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard;

public class FlashCard
{
   public int Id { get; set; }
   public string Question { get; set; } = null!;
   public string Answer { get; set; } = null!;
}
