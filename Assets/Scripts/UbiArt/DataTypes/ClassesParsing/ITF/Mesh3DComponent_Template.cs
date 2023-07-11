namespace UbiArt.ITF {
	public partial class Mesh3DComponent_Template {
		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;
				if (l.LoadAnimations) {
					mesh3D?.LoadObject(s.Context);
					if (mesh3Dlist != null) {
						foreach (var mesh in mesh3Dlist) mesh?.LoadObject(s.Context);
					}
				}
			}
		}
	}
}
