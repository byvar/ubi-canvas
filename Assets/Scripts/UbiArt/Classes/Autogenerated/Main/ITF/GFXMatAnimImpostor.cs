using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class GFXMatAnimImpostor : CSerializable {
		public float animTranslationX;
		public float animTranslationY;
		public float animScaleX;
		public float animScaleY;
		public float animRot;
		public int animIndex;
		public int animTexSizeX;
		public int animTexSizeY;
		public ColorInteger animBackgroundColor;
		public AABB animAABB;
		public float animPhase;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animTranslationX = s.Serialize<float>(animTranslationX, name: "animTranslationX");
			animTranslationY = s.Serialize<float>(animTranslationY, name: "animTranslationY");
			animScaleX = s.Serialize<float>(animScaleX, name: "animScaleX");
			animScaleY = s.Serialize<float>(animScaleY, name: "animScaleY");
			animRot = s.Serialize<float>(animRot, name: "animRot");
			animIndex = s.Serialize<int>(animIndex, name: "animIndex");
			animTexSizeX = s.Serialize<int>(animTexSizeX, name: "animTexSizeX");
			animTexSizeY = s.Serialize<int>(animTexSizeY, name: "animTexSizeY");
			animBackgroundColor = s.SerializeObject<ColorInteger>(animBackgroundColor, name: "animBackgroundColor");
			animAABB = s.SerializeObject<AABB>(animAABB, name: "animAABB");
			animPhase = s.Serialize<float>(animPhase, name: "animPhase");
		}
	}
}

