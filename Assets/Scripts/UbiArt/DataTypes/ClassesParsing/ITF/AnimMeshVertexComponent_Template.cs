using UbiArt.Animation;

namespace UbiArt.ITF {
	public partial class AnimMeshVertexComponent_Template {
		public AnimMeshVertex amv;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad && amvPath != null) {
				Loader l = s.Context.Loader;
				if (l.LoadAnimations) {
					l.LoadFile<AnimMeshVertex>(amvPath, result => amv = result);
				}
			}
		}
	}
}
