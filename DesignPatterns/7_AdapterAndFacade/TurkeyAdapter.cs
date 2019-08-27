using System;

namespace DesignPatterns.AdapterAndFacade
{
    /// <summary>
    /// TurkeyAdapter adapting to IDuck interface.
    /// It de-couples the Client from the Adaptee
    /// i.e. neither knows about each other.
    /// </summary>
    public class TurkeyAdapter : IDuck
    {
        /// <summary>
        /// Adaptee Interface.
        /// We are adapting the <see cref= "ITurkey" />interface to IDuck interface.
        /// </summary>
        private readonly ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey ?? throw new ArgumentNullException(nameof(turkey));
        }

        public void Fly()
        {
            // To match the duck fly range.
            // make turkey fly 5 times
            for(int i = 0; i < 5; ++i)
            {
                _turkey.Fly();
            }
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}
