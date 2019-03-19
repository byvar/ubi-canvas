using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MusicScoreAIComponent_Template : GraphicComponent_Template {
		[Serialize("texture"        )] public Path texture;
		[Serialize("tileLength"     )] public float tileLength;
		[Serialize("widthStart"     )] public float widthStart;
		[Serialize("widthBase"      )] public float widthBase;
		[Serialize("amplitudeSin"   )] public float amplitudeSin;
		[Serialize("frequencySin"   )] public float frequencySin;
		[Serialize("openingSpeed"   )] public float openingSpeed;
		[Serialize("drawUvFromRoot" )] public int drawUvFromRoot;
		[Serialize("intervalNotePNG")] public float intervalNotePNG;
		[Serialize("openSound"      )] public StringID openSound;
		[Serialize("closeSound"     )] public StringID closeSound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(texture));
			SerializeField(s, nameof(tileLength));
			SerializeField(s, nameof(widthStart));
			SerializeField(s, nameof(widthBase));
			SerializeField(s, nameof(amplitudeSin));
			SerializeField(s, nameof(frequencySin));
			SerializeField(s, nameof(openingSpeed));
			SerializeField(s, nameof(drawUvFromRoot));
			SerializeField(s, nameof(intervalNotePNG));
			SerializeField(s, nameof(openSound));
			SerializeField(s, nameof(closeSound));
		}
		public override uint? ClassCRC => 0xC922A1EE;
	}
}

