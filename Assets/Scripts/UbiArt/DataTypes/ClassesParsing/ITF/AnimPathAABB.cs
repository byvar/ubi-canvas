using UbiArt.Animation;

namespace UbiArt.ITF {
	public partial class AnimPathAABB {
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings, s);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings, CSerializerObject s) {
			if (previousSettings != null) {
				if (previousSettings.game != settings.game) {
					/*if (path?.Object != null) {
						var anim = path.GetObject<AnimTrack>();
						aabb = new AABB() {
							MIN = new Vec2d(anim.LocalAABB.MIN.x, anim.LocalAABB.MIN.y),
							MAX = new Vec2d(anim.LocalAABB.MAX.x, anim.LocalAABB.MAX.y)
						};
					}*/
					if (aabb == null || (aabb.MIN == Vec2d.Zero && aabb.MAX == Vec2d.Zero)) {
						if (path?.Object != null) {
							var anim = path.GetObject<AnimTrack>();
							aabb = new AABB() {
								MIN = new Vec2d(anim.LocalAABB.MIN.x, anim.LocalAABB.MIN.y),
								MAX = new Vec2d(anim.LocalAABB.MAX.x, anim.LocalAABB.MAX.y)
							};
							//s?.Context?.SystemLogger?.LogInfo($"Fixed bad AABB: {name} - {s.CurrentPointer}");
						} else {
							aabb = new AABB() {
								MIN = new Vec2d(-10000, -10000),
								MAX = new Vec2d(10000, 10000)
							};
						}
					}
				}
			}
			previousSettings = settings;
		}
	}
}
