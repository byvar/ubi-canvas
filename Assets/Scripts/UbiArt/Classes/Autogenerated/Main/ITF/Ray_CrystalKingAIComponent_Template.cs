using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_CrystalKingAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("checkMapForUnlock")] public StringID checkMapForUnlock;
		[Serialize("textureFile"      )] public Path textureFile;
		[Serialize("tileLen"          )] public float tileLen;
		[Serialize("rayOffsetCrystal" )] public Vector3 rayOffsetCrystal;
		[Serialize("rayOffsetStart"   )] public Vector3 rayOffsetStart;
		[Serialize("widthA"           )] public float widthA;
		[Serialize("widthB"           )] public float widthB;
		[Serialize("widthC"           )] public float widthC;
		[Serialize("widthD"           )] public float widthD;
		[Serialize("speedScroll"      )] public float speedScroll;
		[Serialize("rayZOffset_Part1" )] public float rayZOffset_Part1;
		[Serialize("rayZOffset_Part2" )] public float rayZOffset_Part2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(checkMapForUnlock));
			SerializeField(s, nameof(textureFile));
			SerializeField(s, nameof(tileLen));
			SerializeField(s, nameof(rayOffsetCrystal));
			SerializeField(s, nameof(rayOffsetStart));
			SerializeField(s, nameof(widthA));
			SerializeField(s, nameof(widthB));
			SerializeField(s, nameof(widthC));
			SerializeField(s, nameof(widthD));
			SerializeField(s, nameof(speedScroll));
			SerializeField(s, nameof(rayZOffset_Part1));
			SerializeField(s, nameof(rayZOffset_Part2));
		}
		public override uint? ClassCRC => 0x233D667D;
	}
}

