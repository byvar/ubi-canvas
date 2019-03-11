using UnityEngine;

namespace UbiArt.ITF {
	public partial class FXControl : CSerializable {
		[Serialize("name"                 )] public StringID name;
		[Serialize("fxStopOnEndAnim"      )] public bool fxStopOnEndAnim;
		[Serialize("fxKillOnEndAnim"      )] public bool fxKillOnEndAnim;
		[Serialize("fxPlayOnce"           )] public bool fxPlayOnce;
		[Serialize("pickColorFromFreeze"  )] public bool pickColorFromFreeze;
		[Serialize("fxInstanceOnce"       )] public bool fxInstanceOnce;
		[Serialize("fxEmitFromBase"       )] public bool fxEmitFromBase;
		[Serialize("fxUseActorSpeed"      )] public bool fxUseActorSpeed;
		[Serialize("fxUseActorOrientation")] public bool fxUseActorOrientation;
		[Serialize("fxUseActorAlpha"      )] public bool fxUseActorAlpha;
		[Serialize("fxBoneName"           )] public StringID fxBoneName;
		[Serialize("fxUseBoneOrientation" )] public BOOL fxUseBoneOrientation;
		[Serialize("sounds"               )] public CList<StringID> sounds;
		[Serialize("particles"            )] public CList<StringID> particles;
		[Serialize("fluids"               )] public CList<StringID> fluids;
		[Serialize("music"                )] public StringID music;
		[Serialize("busMix"               )] public StringID busMix;
		[Serialize("owner"                )] public StringID owner;
		[Serialize("busMixActivate"       )] public bool busMixActivate;
		[Serialize("fxDontStopSound"      )] public bool fxDontStopSound;
		[Serialize("fxAttach"             )] public bool fxAttach;
		[Serialize("zOffset"              )] public float zOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(fxStopOnEndAnim));
			SerializeField(s, nameof(fxKillOnEndAnim));
			SerializeField(s, nameof(fxPlayOnce));
			SerializeField(s, nameof(pickColorFromFreeze));
			SerializeField(s, nameof(fxInstanceOnce));
			SerializeField(s, nameof(fxEmitFromBase));
			SerializeField(s, nameof(fxUseActorSpeed));
			SerializeField(s, nameof(fxUseActorOrientation));
			SerializeField(s, nameof(fxUseActorAlpha));
			SerializeField(s, nameof(fxBoneName));
			SerializeField(s, nameof(fxUseBoneOrientation));
			SerializeField(s, nameof(sounds));
			SerializeField(s, nameof(particles));
			SerializeField(s, nameof(fluids));
			SerializeField(s, nameof(music));
			SerializeField(s, nameof(busMix));
			SerializeField(s, nameof(owner));
			SerializeField(s, nameof(busMixActivate));
			SerializeField(s, nameof(fxDontStopSound));
			SerializeField(s, nameof(fxAttach));
			SerializeField(s, nameof(zOffset));
		}
		public enum BOOL {
			[Serialize("BOOL_false")] _false = 0,
			[Serialize("BOOL_true" )] _true = 1,
			[Serialize("BOOL_cond" )] cond = 2,
		}
	}
}

