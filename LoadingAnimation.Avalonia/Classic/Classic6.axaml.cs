using Avalonia.Animation;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;
using Avalonia.Styling;
using LoadingAnimation.Avalonia.Animators;
using System;

namespace LoadingAnimation.Avalonia.Classic
{
    public partial class Classic6 : ClassicBase
    {
        public Classic6()
        {
            InitializeComponent();
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);

            var _animation = new Animation
            {
                Duration = TimeSpan.FromMicroseconds(2000),
                IterationCount = IterationCount.Infinite,
                SpeedRatio = 0.001,
            };
            _animation.Children.Add(new KeyFrame()
            {
                Cue = new Cue(0.0),
                Setters = { new Setter { Property = ClipProperty, Value = new EllipseGeometry() { Center = new(12, 16), RadiusX = 12, RadiusY = 12 } } }
            });
            _animation.Children.Add(new KeyFrame()
            {
                Cue = new Cue(0.5),
                Setters = { new Setter { Property = ClipProperty, Value = new EllipseGeometry() { Center = new(62, 16), RadiusX = 12, RadiusY = 12 } } }
            });
            _animation.Children.Add(new KeyFrame()
            {
                Cue = new Cue(1.0),
                Setters = { new Setter { Property = ClipProperty, Value = new EllipseGeometry() { Center = new(12, 16), RadiusX = 12, RadiusY = 12 } } }
            });

            GeometryAnimator animator = new GeometryAnimator();
            Animation.SetAnimator(_animation.Children[0].Setters[0], animator);
            Animation.SetAnimator(_animation.Children[1].Setters[0], animator);
            Animation.SetAnimator(_animation.Children[2].Setters[0], animator);

            _animation.RunAsync(maskGrid);
        }
    }
}
