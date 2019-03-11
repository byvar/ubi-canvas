using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFXMatAnimImpostor : CSerializable {
		[Serialize("animTranslationX")] public float animTranslationX;
		[Serialize("animTranslationY")] public float animTranslationY;
		[Serialize("animScaleX"      )] public float animScaleX;
		[Serialize("animScaleY"      )] public float animScaleY;
		[Serialize("animRot"         )] public float animRot;
		[Serialize("animIndex"       )] public int animIndex;
		[Serialize("animTexSizeX"    )] public int animTexSizeX;
		[Serialize("animTexSizeY"    )] public int animTexSizeY;
		[Serialize("animAABB"        )] public AABB animAABB;
		[Serialize("animPhase"       )] public float animPhase;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animTranslationX));
			SerializeField(s, nameof(animTranslationY));
			SerializeField(s, nameof(animScaleX));
			SerializeField(s, nameof(animScaleY));
			SerializeField(s, nameof(animRot));
			SerializeField(s, nameof(animIndex));
			SerializeField(s, nameof(animTexSizeX));
			SerializeField(s, nameof(animTexSizeY));
			SerializeField(s, nameof(animAABB));
			SerializeField(s, nameof(animPhase));
		}
	}
}

