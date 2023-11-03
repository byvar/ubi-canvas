namespace UbiArt.ITF {
	public partial class TweenComponent_Template {
		public override ActorComponent Instantiate(Context context) {
			var component = (TweenComponent)base.Instantiate(context);
			component?.InstantiateFromTemplate(context, this);
			return component;
		}
	}
}
