using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SkipLevelComponent_Template : CSerializable {
		[Serialize("textPath"       )] public Path textPath;
		[Serialize("animSize"       )] public Vector2 animSize;
		[Serialize("textAnimSize"   )] public Vector2 textAnimSize;
		[Serialize("screenPos"      )] public Vector2 screenPos;
		[Serialize("textScreenPos"  )] public Vector2 textScreenPos;
		[Serialize("appearAnim"     )] public StringID appearAnim;
		[Serialize("disappearAnim"  )] public StringID disappearAnim;
		[Serialize("talkAnim"       )] public StringID talkAnim;
		[Serialize("locId"          )] public LocalisationId locId;
		[Serialize("rank"           )] public uint rank;
		[Serialize("textRank"       )] public uint textRank;
		[Serialize("contextIconRank")] public uint contextIconRank;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(textPath));
			SerializeField(s, nameof(animSize));
			SerializeField(s, nameof(textAnimSize));
			SerializeField(s, nameof(screenPos));
			SerializeField(s, nameof(textScreenPos));
			SerializeField(s, nameof(appearAnim));
			SerializeField(s, nameof(disappearAnim));
			SerializeField(s, nameof(talkAnim));
			SerializeField(s, nameof(locId));
			SerializeField(s, nameof(rank));
			SerializeField(s, nameof(textRank));
			SerializeField(s, nameof(contextIconRank));
		}
		public override uint? ClassCRC => 0x7B03C524;
	}
}

