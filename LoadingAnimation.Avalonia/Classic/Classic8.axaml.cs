using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;
using Avalonia.Styling;
using LoadingAnimation.Avalonia.Animators;
using System;
using Avalonia;

namespace LoadingAnimation.Avalonia.Classic
{
    public partial class Classic8 : ClassicBase
    {
        public Classic8()
        {
            InitializeComponent();
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);

            var _animation2 = new Animation
            {
                Duration = TimeSpan.FromMicroseconds(1500),
                IterationCount = IterationCount.Infinite,
                SpeedRatio = 0.001,
                
            };
            _animation2.Children.Add(new KeyFrame()
            {
                Cue = new Cue(0.0),
                Setters = { new Setter { Property = ClipProperty, Value = new RectangleGeometry() { Rect = new Rect(0, 0, 100, 32) } } }
            });
            _animation2.Children.Add(new KeyFrame()
            {
                Cue = new Cue(0.5),
                Setters = { new Setter { Property = ClipProperty, Value = new RectangleGeometry() { Rect = new Rect(0, 0, 0, 32) } } }
            });
            _animation2.Children.Add(new KeyFrame()
            {
                Cue = new Cue(1.0),
                Setters = { new Setter { Property = ClipProperty, Value = new RectangleGeometry() { Rect = new Rect(0, 0, 100, 32) } } }
            });

            GeometryAnimator animator2 = new GeometryAnimator();
            Animation.SetAnimator(_animation2.Children[0].Setters[0], animator2);
            Animation.SetAnimator(_animation2.Children[1].Setters[0], animator2);
            Animation.SetAnimator(_animation2.Children[2].Setters[0], animator2);

            _animation2.RunAsync(maskGrid2);
        }
    }
}
