using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BubbleDreamerComponent_Template : ActorComponent_Template {
		[Serialize("Quotes"          )] public CList<Quote> Quotes;
		[Serialize("QuoteMaxDuration")] public float QuoteMaxDuration;
		[Serialize("TimeBeforeSleep" )] public float TimeBeforeSleep;
		[Serialize("DistToPopBubble" )] public float DistToPopBubble;
		[Serialize("FontMood"        )] public uint FontMood;
		[Serialize("FontMoodSpecial" )] public uint FontMoodSpecial;
		[Serialize("RetroMapCoeff"   )] public float RetroMapCoeff;
		[Serialize("MapColor"        )] public Color MapColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Quotes));
			SerializeField(s, nameof(QuoteMaxDuration));
			SerializeField(s, nameof(TimeBeforeSleep));
			SerializeField(s, nameof(DistToPopBubble));
			SerializeField(s, nameof(FontMood));
			SerializeField(s, nameof(FontMoodSpecial));
			SerializeField(s, nameof(RetroMapCoeff));
			SerializeField(s, nameof(MapColor));
		}
		public override uint? ClassCRC => 0x706DE95E;
	}
}

