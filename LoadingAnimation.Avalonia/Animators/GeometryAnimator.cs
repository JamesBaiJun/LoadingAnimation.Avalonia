using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls.Shapes;
using Avalonia.Controls;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingAnimation.Avalonia.Animators
{
    public class GeometryAnimator : InterpolatingAnimator<Geometry>
    {
        public GeometryAnimator()
        {
        }

        public override Geometry Interpolate(double progress, Geometry oldValue, Geometry newValue)
        {
            if (oldValue is RectangleGeometry oldRect && newValue is RectangleGeometry newRect)
            {
                var radiusX = oldRect.Rect.Width + (newRect.Rect.Width - oldRect.Rect.Width) * progress;
                var radiusY = oldRect.Rect.Height + (newRect.Rect.Height - oldRect.Rect.Height) * progress;

                return new RectangleGeometry() { Rect = new Rect(0, 0, radiusX, radiusY) };
            }
            else if (oldValue is EllipseGeometry oldEllipse && newValue is EllipseGeometry newEllipse)
            {
                var centerX = oldEllipse.Center.X + (newEllipse.Center.X - oldEllipse.Center.X) * progress;
                var centerY = oldEllipse.Center.Y + (newEllipse.Center.Y - oldEllipse.Center.Y) * progress;
                var radiusX = oldEllipse.RadiusX + (newEllipse.RadiusX - oldEllipse.RadiusX) * progress;
                var radiusY = oldEllipse.RadiusY + (newEllipse.RadiusY - oldEllipse.RadiusY) * progress;

                return new EllipseGeometry() { Center = new(centerX, centerY), RadiusX = radiusX, RadiusY = radiusY };
            }


            return oldValue;
        }
    }
}
