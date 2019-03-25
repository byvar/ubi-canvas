using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.VH)]
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
		[Serialize("attractor"            )] public ObjectPath attractor;
		[Serialize("zOffset"              )] public float zOffset;
		
		[Serialize("fxUseBoneOrientation" )] public bool fxUseBoneOrientationBool;
		[Serialize("sound"                )] public StringID sound;
		[Serialize("particle"             )] public StringID particle;
		[Serialize("playContact"          )] public int playContact;
		
		[Serialize("bool__16"             )] public bool bool__16;
		[Serialize("bool__17"             )] public bool bool__17;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(fxStopOnEndAnim));
				SerializeField(s, nameof(fxPlayOnce));
				SerializeField(s, nameof(fxEmitFromBase));
				SerializeField(s, nameof(fxUseActorSpeed));
				SerializeField(s, nameof(fxUseActorOrientation));
				SerializeField(s, nameof(fxBoneName));
				SerializeField(s, nameof(fxUseBoneOrientationBool));
				SerializeField(s, nameof(sound));
				SerializeField(s, nameof(particle));
				SerializeField(s, nameof(playContact));
				SerializeField(s, nameof(sounds));
				SerializeField(s, nameof(particles));
				SerializeField(s, nameof(owner));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(fxStopOnEndAnim));
				SerializeField(s, nameof(fxPlayOnce));
				SerializeField(s, nameof(fxInstanceOnce));
				SerializeField(s, nameof(fxEmitFromBase));
				SerializeField(s, nameof(fxUseActorSpeed));
				SerializeField(s, nameof(fxUseActorOrientation));
				SerializeField(s, nameof(fxUseActorAlpha));
				SerializeField(s, nameof(fxBoneName));
				SerializeField(s, nameof(fxUseBoneOrientation));
				SerializeField(s, nameof(sounds));
				SerializeField(s, nameof(particles));
				SerializeField(s, nameof(music));
				SerializeField(s, nameof(busMix));
				SerializeField(s, nameof(owner));
				SerializeField(s, nameof(busMixActivate), boolAsByte: true);
				SerializeField(s, nameof(fxDontStopSound), boolAsByte: true);
			} else if(Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(fxStopOnEndAnim), boolAsByte: true);
				SerializeField(s, nameof(fxPlayOnce), boolAsByte: true);
				SerializeField(s, nameof(fxInstanceOnce), boolAsByte: true);
				SerializeField(s, nameof(fxEmitFromBase), boolAsByte: true);
				SerializeField(s, nameof(fxUseActorSpeed), boolAsByte: true);
				SerializeField(s, nameof(fxUseActorOrientation), boolAsByte: true);
				SerializeField(s, nameof(fxUseActorAlpha), boolAsByte: true);
				SerializeField(s, nameof(fxBoneName));
				SerializeField(s, nameof(fxUseBoneOrientation));
				SerializeField(s, nameof(sounds));
				SerializeField(s, nameof(particles));
				SerializeField(s, nameof(music));
				SerializeField(s, nameof(busMix));
				SerializeField(s, nameof(owner));
				SerializeField(s, nameof(busMixActivate), boolAsByte: true);
				SerializeField(s, nameof(fxDontStopSound), boolAsByte: true);
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(fxStopOnEndAnim));
				SerializeField(s, nameof(bool__16));
				SerializeField(s, nameof(bool__17));
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
			} else {
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
				SerializeField(s, nameof(attractor));
				SerializeField(s, nameof(zOffset));
			}
		}
		public enum BOOL {
			[Serialize("BOOL_false")] _false = 0,
			[Serialize("BOOL_true" )] _true = 1,
			[Serialize("BOOL_cond" )] cond = 2,
		}
	}
}

