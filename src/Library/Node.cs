using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node : IAcceptVisitor
    {
        private int number;
        private string nombre;

        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }
        public string Nombre {
            get
            {
                return this.nombre;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number)
        {
            this.number = number;
        }

         public Node(Persona persona)
        {
            this.nombre = persona.Nombre;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
    
        public void Accept (IVisitor visitor)
        {
            visitor.Visit(this);
        }
        
    }
}
