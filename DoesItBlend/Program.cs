using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main()
        {
            List<IBlendable> blendables = new List<IBlendable>();
            blendables.Add(new Strawberry());
            blendables.Add(new Banana());
            blendables.Add(new CellPhone());
            blendables.Add(new IceCubes());
            blendables.Add(new Banana());
            
            for (int i = 0; i < 10; i++)
                blendables.Add(new Mango());

                string mess = "";
            foreach(IBlendable blendable in blendables){
                mess += blendable.Blend();
                mess += "\n";
            }
            Console.WriteLine(mess);

        }
    }
}
