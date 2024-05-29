using Avalonia;
using Avalonia.Animation;
using Avalonia.Animation.Easings;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Media;
using Avalonia.Styling;
using LoadingAnimation.Avalonia.Animators;
using System;

namespace LoadingAnimation.Avalonia.Classic
{
    public partial class Classic3 : UserControl
    {
        public Classic3()
        {
            InitializeComponent();
            Loaded += Classic3_Loaded;
        }

        private void Classic3_Loaded(object? sender, global::Avalonia.Interactivity.RoutedEventArgs e)
        {
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);

            var _animation = new Animation
            {
                Duration = TimeSpan.FromMicroseconds(3000),
                IterationCount = IterationCount.Infinite,
                SpeedRatio = 0.001,
            };
            _animation.Children.Add(new KeyFrame()
            {
                Cue = new Cue(0.0),
                Setters = { new Setter { Property = ClipProperty, Value = new RectangleGeometry() { Rect = new Rect(new Size(0, 20)) } } }
            });
            _animation.Children.Add(new KeyFrame()
            {
                Cue = new Cue(0.6),
                Setters = { new Setter { Property = ClipProperty, Value = new RectangleGeometry() { Rect = new Rect(new Size(70, 20)) } } }
            });
            _animation.Children.Add(new KeyFrame()
            {
                Cue = new Cue(1.0),
                Setters = { new Setter { Property = ClipProperty, Value = new RectangleGeometry() { Rect = new Rect(new Size(0, 20)) } } }
            });

            GeometryAnimator animator = new GeometryAnimator();
            Animation.SetAnimator(_animation.Children[0].Setters[0], animator);
            Animation.SetAnimator(_animation.Children[1].Setters[0], animator);
            Animation.SetAnimator(_animation.Children[2].Setters[0], animator);

            _animation.RunAsync(txtBlock);

        }
    }
}
