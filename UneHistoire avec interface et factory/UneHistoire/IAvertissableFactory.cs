using System;

namespace UneHistoire
{
    public class IAvertissableFactory
    {
        /// <summary>
        /// Create est une méthode factory qui crée des objets de type IAvertissable
        /// </summary>
        /// <param name="typeAvertissable">String qui contient le type concret de l'objet à créé</param>
        /// <returns>Un objet de type IAvertissable ou null si type inconnu</returns>
        internal static IAvertissable Create(string pTypeAvertissable, string pNom = "")
        {
            IAvertissable ia = null;
            switch (pTypeAvertissable.ToLower())
            {
                case "ami":
                    ia = new Ami(pNom);
                    break;
                case "boss":
                    ia = new Boss(pNom);
                    break;
                case "wife":
                    ia = new Wife(pNom);
                    break;
                case "radiator":
                    ia = new Radiator(pNom);
                    break;
                default:
                    ia = null;
                    break;
            }
            return ia;
        }
    }
}