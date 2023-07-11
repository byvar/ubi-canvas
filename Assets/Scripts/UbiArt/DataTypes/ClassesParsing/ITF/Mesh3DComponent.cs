namespace UbiArt.ITF {
	public partial class Mesh3DComponent {
		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;
				if (l.LoadAnimations) {
					mesh3D?.LoadObject(s.Context);
					if (mesh3DList != null) {
						foreach (var mesh in mesh3DList) mesh?.LoadObject(s.Context);
					}
				}
			}
		}
	}
}
