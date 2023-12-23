using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3th
{
    internal class RigidBody : Component
    {
        private float gravity = 9.81f;

        public RigidBody()
        {
            Console.WriteLine("RigidBody 생성");
        }

        public void Information()
        { 
            Console.WriteLine("Componet의 x ; " + x );
            Console.WriteLine("Componet의 y ; " + y);
            Console.WriteLine("Componet의 z ; " + z );

            Console.WriteLine("Componet의 gravity ; " + gravity );
        }
    }
}
