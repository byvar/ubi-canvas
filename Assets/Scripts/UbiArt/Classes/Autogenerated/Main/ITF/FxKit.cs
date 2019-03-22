using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class FxKit : CSerializable {
		[Serialize("CList<FxKit.Fx>__0"                )] public CList<FxKit.Fx> CList_FxKit_Fx__0;
		[Serialize("StringID__1"                       )] public StringID StringID__1;
		[Serialize("CList<SoundDescriptor_Template>__2")] public CList<SoundDescriptor_Template> CList_SoundDescriptor_Template__2;
		[Serialize("CList<FxDescriptor_Template>__3"   )] public CList<FxDescriptor_Template> CList_FxDescriptor_Template__3;
		[Serialize("CMap<ITF::StringID, Target>__4"    )] public CMap<StringID, Target> CMap__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CList_FxKit_Fx__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(CList_SoundDescriptor_Template__2));
			SerializeField(s, nameof(CList_FxDescriptor_Template__3));
			SerializeField(s, nameof(CMap__4));
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class Fx : CSerializable {
			[Serialize("StringID__0")] public StringID StringID__0;
			[Serialize("StringID__1")] public StringID StringID__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1));
			}
		}
	}
}

