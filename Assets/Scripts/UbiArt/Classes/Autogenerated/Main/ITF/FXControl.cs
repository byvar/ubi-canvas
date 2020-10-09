using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.VH | GameFlags.RA)]
	public partial class FXControl : CSerializable {
		public StringID name;
		public bool fxStopOnEndAnim;
		public bool fxKillOnEndAnim;
		public bool fxPlayOnce;
		public bool pickColorFromFreeze;
		public bool fxInstanceOnce;
		public bool fxEmitFromBase;
		public bool fxUseActorSpeed;
		public bool fxUseActorOrientation;
		public bool fxUseActorAlpha;
		public StringID fxBoneName;
		public BOOL fxUseBoneOrientation;
		public CListO<StringID> sounds;
		public CListO<StringID> particles;
		public CListO<StringID> fluids;
		public StringID music;
		public StringID busMix;
		public StringID owner;
		public bool busMixActivate;
		public bool fxDontStopSound;
		public bool fxAttach;
		public ObjectPath attractor;
		public float zOffset;
		
		public bool fxUseBoneOrientationBool;
		public StringID sound;
		public StringID particle;
		public int playContact;
		
		public bool bool__16;
		public bool bool__17;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				name = s.SerializeObject<StringID>(name, name: "name");
				fxStopOnEndAnim = s.Serialize<bool>(fxStopOnEndAnim, name: "fxStopOnEndAnim");
				fxPlayOnce = s.Serialize<bool>(fxPlayOnce, name: "fxPlayOnce");
				fxEmitFromBase = s.Serialize<bool>(fxEmitFromBase, name: "fxEmitFromBase");
				fxUseActorSpeed = s.Serialize<bool>(fxUseActorSpeed, name: "fxUseActorSpeed");
				fxUseActorOrientation = s.Serialize<bool>(fxUseActorOrientation, name: "fxUseActorOrientation");
				fxBoneName = s.SerializeObject<StringID>(fxBoneName, name: "fxBoneName");
				fxUseBoneOrientationBool = s.Serialize<bool>(fxUseBoneOrientationBool, name: "fxUseBoneOrientation");
				sound = s.SerializeObject<StringID>(sound, name: "sound");
				particle = s.SerializeObject<StringID>(particle, name: "particle");
				playContact = s.Serialize<int>(playContact, name: "playContact");
				sounds = s.SerializeObject<CListO<StringID>>(sounds, name: "sounds");
				particles = s.SerializeObject<CListO<StringID>>(particles, name: "particles");
				owner = s.SerializeObject<StringID>(owner, name: "owner");
			} else if (Settings.s.game == Settings.Game.RL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				fxStopOnEndAnim = s.Serialize<bool>(fxStopOnEndAnim, name: "fxStopOnEndAnim");
				fxPlayOnce = s.Serialize<bool>(fxPlayOnce, name: "fxPlayOnce");
				fxInstanceOnce = s.Serialize<bool>(fxInstanceOnce, name: "fxInstanceOnce");
				fxEmitFromBase = s.Serialize<bool>(fxEmitFromBase, name: "fxEmitFromBase");
				fxUseActorSpeed = s.Serialize<bool>(fxUseActorSpeed, name: "fxUseActorSpeed");
				fxUseActorOrientation = s.Serialize<bool>(fxUseActorOrientation, name: "fxUseActorOrientation");
				fxUseActorAlpha = s.Serialize<bool>(fxUseActorAlpha, name: "fxUseActorAlpha");
				fxBoneName = s.SerializeObject<StringID>(fxBoneName, name: "fxBoneName");
				fxUseBoneOrientation = s.Serialize<BOOL>(fxUseBoneOrientation, name: "fxUseBoneOrientation");
				sounds = s.SerializeObject<CListO<StringID>>(sounds, name: "sounds");
				particles = s.SerializeObject<CListO<StringID>>(particles, name: "particles");
				music = s.SerializeObject<StringID>(music, name: "music");
				busMix = s.SerializeObject<StringID>(busMix, name: "busMix");
				owner = s.SerializeObject<StringID>(owner, name: "owner");
				busMixActivate = s.Serialize<bool>(busMixActivate, name: "busMixActivate", options: CSerializerObject.Options.BoolAsByte);
				fxDontStopSound = s.Serialize<bool>(fxDontStopSound, name: "fxDontStopSound", options: CSerializerObject.Options.BoolAsByte);
			} else if(Settings.s.game == Settings.Game.COL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				fxStopOnEndAnim = s.Serialize<bool>(fxStopOnEndAnim, name: "fxStopOnEndAnim", options: CSerializerObject.Options.BoolAsByte);
				fxPlayOnce = s.Serialize<bool>(fxPlayOnce, name: "fxPlayOnce", options: CSerializerObject.Options.BoolAsByte);
				fxInstanceOnce = s.Serialize<bool>(fxInstanceOnce, name: "fxInstanceOnce", options: CSerializerObject.Options.BoolAsByte);
				fxEmitFromBase = s.Serialize<bool>(fxEmitFromBase, name: "fxEmitFromBase", options: CSerializerObject.Options.BoolAsByte);
				fxUseActorSpeed = s.Serialize<bool>(fxUseActorSpeed, name: "fxUseActorSpeed", options: CSerializerObject.Options.BoolAsByte);
				fxUseActorOrientation = s.Serialize<bool>(fxUseActorOrientation, name: "fxUseActorOrientation", options: CSerializerObject.Options.BoolAsByte);
				fxUseActorAlpha = s.Serialize<bool>(fxUseActorAlpha, name: "fxUseActorAlpha", options: CSerializerObject.Options.BoolAsByte);
				fxBoneName = s.SerializeObject<StringID>(fxBoneName, name: "fxBoneName");
				fxUseBoneOrientation = s.Serialize<BOOL>(fxUseBoneOrientation, name: "fxUseBoneOrientation");
				sounds = s.SerializeObject<CListO<StringID>>(sounds, name: "sounds");
				particles = s.SerializeObject<CListO<StringID>>(particles, name: "particles");
				music = s.SerializeObject<StringID>(music, name: "music");
				busMix = s.SerializeObject<StringID>(busMix, name: "busMix");
				owner = s.SerializeObject<StringID>(owner, name: "owner");
				busMixActivate = s.Serialize<bool>(busMixActivate, name: "busMixActivate", options: CSerializerObject.Options.BoolAsByte);
				fxDontStopSound = s.Serialize<bool>(fxDontStopSound, name: "fxDontStopSound", options: CSerializerObject.Options.BoolAsByte);
			} else if (Settings.s.game == Settings.Game.VH) {
				name = s.SerializeObject<StringID>(name, name: "name");
				fxStopOnEndAnim = s.Serialize<bool>(fxStopOnEndAnim, name: "fxStopOnEndAnim");
				bool__16 = s.Serialize<bool>(bool__16, name: "bool__16");
				bool__17 = s.Serialize<bool>(bool__17, name: "bool__17");
				fxInstanceOnce = s.Serialize<bool>(fxInstanceOnce, name: "fxInstanceOnce");
				fxEmitFromBase = s.Serialize<bool>(fxEmitFromBase, name: "fxEmitFromBase");
				fxUseActorSpeed = s.Serialize<bool>(fxUseActorSpeed, name: "fxUseActorSpeed");
				fxUseActorOrientation = s.Serialize<bool>(fxUseActorOrientation, name: "fxUseActorOrientation");
				fxUseActorAlpha = s.Serialize<bool>(fxUseActorAlpha, name: "fxUseActorAlpha");
				fxBoneName = s.SerializeObject<StringID>(fxBoneName, name: "fxBoneName");
				fxUseBoneOrientation = s.Serialize<BOOL>(fxUseBoneOrientation, name: "fxUseBoneOrientation");
				sounds = s.SerializeObject<CListO<StringID>>(sounds, name: "sounds");
				particles = s.SerializeObject<CListO<StringID>>(particles, name: "particles");
				fluids = s.SerializeObject<CListO<StringID>>(fluids, name: "fluids");
				music = s.SerializeObject<StringID>(music, name: "music");
				busMix = s.SerializeObject<StringID>(busMix, name: "busMix");
				owner = s.SerializeObject<StringID>(owner, name: "owner");
				busMixActivate = s.Serialize<bool>(busMixActivate, name: "busMixActivate");
				fxDontStopSound = s.Serialize<bool>(fxDontStopSound, name: "fxDontStopSound");
				fxAttach = s.Serialize<bool>(fxAttach, name: "fxAttach");
			} else {
				name = s.SerializeObject<StringID>(name, name: "name");
				fxStopOnEndAnim = s.Serialize<bool>(fxStopOnEndAnim, name: "fxStopOnEndAnim");
				fxKillOnEndAnim = s.Serialize<bool>(fxKillOnEndAnim, name: "fxKillOnEndAnim");
				fxPlayOnce = s.Serialize<bool>(fxPlayOnce, name: "fxPlayOnce");
				pickColorFromFreeze = s.Serialize<bool>(pickColorFromFreeze, name: "pickColorFromFreeze");
				fxInstanceOnce = s.Serialize<bool>(fxInstanceOnce, name: "fxInstanceOnce");
				fxEmitFromBase = s.Serialize<bool>(fxEmitFromBase, name: "fxEmitFromBase");
				fxUseActorSpeed = s.Serialize<bool>(fxUseActorSpeed, name: "fxUseActorSpeed");
				fxUseActorOrientation = s.Serialize<bool>(fxUseActorOrientation, name: "fxUseActorOrientation");
				fxUseActorAlpha = s.Serialize<bool>(fxUseActorAlpha, name: "fxUseActorAlpha");
				fxBoneName = s.SerializeObject<StringID>(fxBoneName, name: "fxBoneName");
				fxUseBoneOrientation = s.Serialize<BOOL>(fxUseBoneOrientation, name: "fxUseBoneOrientation");
				sounds = s.SerializeObject<CListO<StringID>>(sounds, name: "sounds");
				particles = s.SerializeObject<CListO<StringID>>(particles, name: "particles");
				fluids = s.SerializeObject<CListO<StringID>>(fluids, name: "fluids");
				music = s.SerializeObject<StringID>(music, name: "music");
				busMix = s.SerializeObject<StringID>(busMix, name: "busMix");
				owner = s.SerializeObject<StringID>(owner, name: "owner");
				busMixActivate = s.Serialize<bool>(busMixActivate, name: "busMixActivate");
				fxDontStopSound = s.Serialize<bool>(fxDontStopSound, name: "fxDontStopSound");
				fxAttach = s.Serialize<bool>(fxAttach, name: "fxAttach");
				attractor = s.SerializeObject<ObjectPath>(attractor, name: "attractor");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			}
		}
		public enum BOOL {
			[Serialize("BOOL_false")] _false = 0,
			[Serialize("BOOL_true" )] _true = 1,
			[Serialize("BOOL_cond" )] cond = 2,
		}
	}
}

