﻿#region Imports

using System.Drawing;
using System.Windows.Forms;
using ReaLTaiizor.Enum.Poison;

#endregion

namespace ReaLTaiizor.Animate.Poison
{
    #region MoveAnimationAnimate

    public sealed class MoveAnimation : Animate
    {
        public void Start(Control control, Point targetPoint, TransitionType transitionType, int duration)
        {
            base.Start(control, transitionType, duration,
                delegate
                {
                    int x = DoMoveAnimation(control.Location.X, targetPoint.X);
                    int y = DoMoveAnimation(control.Location.Y, targetPoint.Y);

                    control.Location = new(x, y);
                },
                delegate
                {
                    return (control.Location.Equals(targetPoint));
                });
        }

        private int DoMoveAnimation(int startPos, int targetPos)
        {
            float t = (float)counter - startTime;
            float b = (float)startPos;
            float c = (float)targetPos - startPos;
            float d = (float)targetTime - startTime;

            return MakeTransition(t, b, d, c);
        }
    }

    #endregion
}