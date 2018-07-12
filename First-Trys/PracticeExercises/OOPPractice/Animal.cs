using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public TypeOfGender Gender { get; set; }
        public TypePublicRelation PublicRelation { get; set; }        
    } 

}

public string speak()
{
    var goodBoy = "I'm a good boy";
    return goodBoy;
}