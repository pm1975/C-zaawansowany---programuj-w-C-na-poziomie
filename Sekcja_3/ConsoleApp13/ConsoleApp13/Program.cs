using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region part1
            var animationDirection = default(AnimationDirection);

            animationDirection = AnimationDirection.Left;

            var enumString = animationDirection.ToString();

            var enumFromString = Enum.Parse(typeof(AnimationDirection), enumString);

            Animate(animationDirection);

            foreach (var enumValue in Enum.GetValues(typeof(AnimationDirection)))
                Console.WriteLine(enumValue);
            #endregion

            // | and & - flags

            // one | is as + in strings
            var userPermissions = UserPermissions.Create | UserPermissions.Delete;

            //read if userPermissions contain UserPermissions.Create
            if ((userPermissions & UserPermissions.Create) == UserPermissions.Create)
            {

            }
        }
        #region part1
        public static void Animate(AnimationDirection animationDirection)
        {
            Console.WriteLine($"Animuje teraz obrazek z {animationDirection.ToString()}");
        }
        #endregion
    }
    #region part1
    public enum AnimationDirection
    {
        Unknown = 0,
        Left,
        Right,
        Up,
        Down
    }
    #endregion

    public enum UserPermissions
    {
        Create = 1, 
        Delete = 2,
        Write = 4,
        Read = 8
    }
}
