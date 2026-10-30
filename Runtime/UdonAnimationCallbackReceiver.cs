using UdonSharp;

namespace net.puk06.UdonAnimation
{
    /// <summary>
    /// Base class for custom receivers driven by <see cref="UdonAnimationSystem.SetCustomReceiver"/>.
    /// Inherit from this class and pass the behaviour to the animation system to receive progress callbacks.
    /// </summary>
    public abstract class UdonAnimationCallbackReceiver : UdonSharpBehaviour
    {
        /// <summary>
        /// Called every frame while the animation is running.
        /// </summary>
        /// <param name="identifier">The identifier passed to SetCustomReceiver. Empty when none was specified.</param>
        /// <param name="eased">The eased progress of the animation, from 0 to 1.</param>
        public abstract void OnAnimationUpdate(string identifier, float eased);

        /// <summary>
        /// Called once when the animation completes. Override only if needed.
        /// </summary>
        /// <param name="identifier">The identifier passed to SetCustomReceiver. Empty when none was specified.</param>
        public virtual void OnAnimationComplete(string identifier) { }
    }
}
