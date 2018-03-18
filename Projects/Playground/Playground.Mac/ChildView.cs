﻿// This file has been autogenerated from a class added in the UI designer.

using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platform.Mac.Presenters.Attributes;
using MvvmCross.Platform.Mac.Views;
using Playground.Core.ViewModels;

namespace Playground.Mac
{
    [MvxFromStoryboard("Main")]
    [MvxContentPresentation]
    public partial class ChildView : MvxViewController<ChildViewModel>
    {
        public ChildView(IntPtr handle) : base(handle)
        {
            Title = "Child view";
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<ChildView, ChildViewModel>();
            set.Bind(btnRoot).To(vm => vm.ShowRootCommand);
            set.Apply();
        }
    }
}