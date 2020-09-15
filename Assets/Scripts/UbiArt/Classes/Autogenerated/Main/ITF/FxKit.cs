using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class FxKit : CSerializable {
		public CList<FxKit.Fx> CList_FxKit_Fx__0;
		public StringID StringID__1;
		public CList<SoundDescriptor_Template> CList_SoundDescriptor_Template__2;
		public CList<FxDescriptor_Template> CList_FxDescriptor_Template__3;
		public CMap<StringID, Target> CMap__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CList_FxKit_Fx__0 = s.SerializeObject<CList<FxKit.Fx>>(CList_FxKit_Fx__0, name: "CList_FxKit_Fx__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			CList_SoundDescriptor_Template__2 = s.SerializeObject<CList<SoundDescriptor_Template>>(CList_SoundDescriptor_Template__2, name: "CList_SoundDescriptor_Template__2");
			CList_FxDescriptor_Template__3 = s.SerializeObject<CList<FxDescriptor_Template>>(CList_FxDescriptor_Template__3, name: "CList_FxDescriptor_Template__3");
			CMap__4 = s.SerializeObject<CMap<StringID, Target>>(CMap__4, name: "CMap__4");
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class Fx : CSerializable {
			public StringID StringID__0;
			public StringID StringID__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
				StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			}
		}
	}
}

