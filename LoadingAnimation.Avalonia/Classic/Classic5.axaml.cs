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
    public partial class Classic5 : UserControl
    {
        public Classic5()
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
                Setters = { new Setter { Property = ClipProperty, Value = new RectangleGeometry() { Rect = new Rect(new Size(0, 28)) } } }
            });
            _animation.Children.Add(new KeyFrame()
            {
                Cue = new Cue(1.0),
                Setters = { new Setter { Property = ClipProperty, Value = new RectangleGeometry() { Rect = new Rect(new Size(100, 28)) } } }
            });

            GeometryAnimator animator = new GeometryAnimator();
            Animation.SetAnimator(_animation.Children[0].Setters[0], animator);
            Animation.SetAnimator(_animation.Children[1].Setters[0], animator);

            _animation.RunAsync(maskGrid);
        }
    }
}
