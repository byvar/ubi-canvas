using System;
using UbiArt.ITF;

namespace UbiArt {
	public class Generic<T> : ICSerializable, IObjectContainer where T : CSerializable {
		[Serialize("$ClassName$")] public StringID className;
		public T obj;
		public bool serializeClassName = true;

		public string ClassName => obj?.ClassName;

		public Generic() {
			className = new StringID();
		}

		public Generic(T obj) {
			if (obj != null && obj.ClassCRC.HasValue) {
				className = new StringID(obj.ClassCRC.Value);
				this.obj = obj;
			} else {
				className = new StringID();
			}
		}

		public bool IsNull {
			get {
				return className == null || className.IsNull;
			}
		}

		public void SerializeClassName(CSerializerObject s) {
			if (s.Settings.engineVersion <= Settings.EngineVersion.RO) {
				className = s.SerializeObject<StringID>(className, name: "NAME");
			} else {
				className = s.SerializeObject<StringID>(className, name: "$ClassName$");
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			Reinit(s.Context, s.Settings);
			Pointer pos = s.CurrentPointer;
			if (serializeClassName) {
				SerializeClassName(s);
			}
			/*s.Serialize(this, GetType().GetField(nameof(className)),
				(SerializeAttribute)GetType().GetField(nameof(className)).GetCustomAttributes(typeof(SerializeAttribute), false).First());*/
			if (className.IsNull) {
				obj = default;
			} else {
				if (ObjectFactory.classes.ContainsKey(className.stringID)) {
					/*if (s.log) {
						MapLoader.Loader.Log(pos + ":" + new string(' ', (s.Indent + 1) * 2) + "$ClassName$ - " + className.stringID.ToString("X8") + "(" + ObjectFactory.classes[className.stringID] + ")");
					}*/
					Type type = ObjectFactory.classes[className.stringID];
					if (type.ContainsGenericParameters) {
						if (!typeof(T).IsGenericType) {
							s.Context.SystemLogger?.LogError(s.CurrentPointer + " - Generic parameters error with type " + type + ". Expecting type " + typeof(T) + ".");
							throw new Exception(s.CurrentPointer + " - Generic parameters error with type " + type + ". Expecting type " + typeof(T) + ".");
						}
						type = type.MakeGenericType(typeof(T).GetGenericArguments());
					}
					obj = s.SerializeGeneric<T>(obj, type);
				} else {
					if (s is CSerializerObjectTagBinary) {
						s.Context.SystemLogger?.LogWarning("CRC " + className.stringID.ToString("X8")
							+ " found at " + s.CurrentPointer
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
						className.stringID = 0xFFFFFFFF;
					} else {
						s.Context.SystemLogger?.LogError("CRC " + className.stringID.ToString("X8")
							+ " found at " + s.CurrentPointer
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
						throw new NotImplementedException("CRC " + className.stringID.ToString("X8")
							+ " found at position " + s.CurrentPointer
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
					}
				}
			}
		}


		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.game != settings.game) {
					if (obj != null) {
						if (obj is ITF.Event e) {
							if (e.IsAdventuresExclusive()) MakeNull();
						}
					}
					if (obj != null) {
						var attr = (GamesAttribute)Attribute.GetCustomAttribute(obj.GetType(), typeof(GamesAttribute));
						if (attr != null) {
							if (!attr.HasGame(settings.game)) {
								if (obj is RO2_BTActionCovertWithHat_Template btHat) {
									var newBT = Merger.Merge<RO2_BTActionCovertFromTarget_Template>(btHat);
									newBT.animStandUp = btHat.animIdle;
									newBT.animUTurnDn = btHat.animIdle;
									newBT.animUTurnUp = btHat.animIdle;
									newBT.animMoveShieldDn = btHat.animIdle;
									newBT.animMoveShieldUp = btHat.animIdle;
									newBT.animUturnUpEvent = btHat.animIdle;
									newBT.factTarget = btHat.factTarget;
									obj = (T)(object)newBT;
									className = new StringID(obj.ClassCRC.Value);
								} else if (obj is RO2_BTActionDash_Template btDash) {
									var newBT = Merger.Merge<RO2_BTActionCharge_Template>(btDash);
									newBT.animRun = btDash.animDash;
									newBT.animEndRun = btDash.animEndDash;
									newBT.animAnticip = btDash.animAnticip;
									newBT.animHitWall = btDash.animHitWall;
									newBT.animHoleStop = btDash.animHoleStop;
									newBT.distMaxCharge = btDash.distMaxCharge;
									newBT.name = btDash.name;
									obj = (T)(object)newBT;
									className = new StringID(obj.ClassCRC.Value);
								} else if (obj is RO2_BTActionJumpAttack_Template btJump) {
									var newBT = Merger.Merge<RO2_BTActionJumpJanod_Template>(btJump);
									newBT.animJump = btJump.animJump;
									newBT.animLanding = btJump.animReception;
									newBT.animAnticip = btJump.animAnticip;
									newBT.animIdle = btJump.animWallStand;
									newBT.name = btJump.name;
									obj = (T)(object)newBT;
									className = new StringID(obj.ClassCRC.Value);
								} else if (obj is RO2_BTActionAppearBackground_Rope_Template btRope) {
									var newBT = Merger.Merge<RO2_BTActionAppearBackgroundLadders_Template>(btRope);
									newBT.name = btRope.name;
									obj = (T)(object)newBT;
									className = new StringID(obj.ClassCRC.Value);
								} else if (obj is RO2_BTActionAppearBasket_Template btBasket) {
									var newBT = Merger.Merge<RO2_BTActionAppearFromGround_Template>(btBasket);
									newBT.anim = btBasket.animAppear;
									newBT.name = btBasket.name;
									obj = (T)(object)newBT;
									className = new StringID(obj.ClassCRC.Value);
								} else if (obj is EventBreakableBreak evbreak) {
									var newEv = Merger.Merge<RO2_EventBreakableBreak>(evbreak);
									obj = (T)(object)newEv;
									className = new StringID(obj.ClassCRC.Value);
								} else if (obj is EventBreakableQuery evquery) {
									var newEv = Merger.Merge<RO2_EventBreakableQuery>(evquery);
									obj = (T)(object)newEv;
									className = new StringID(obj.ClassCRC.Value);
								} else if (obj is PlayWwise_evtTemplate wwiseEvtTpl) {
									var newEv = Merger.Merge<PlaySound_evtTemplate>(wwiseEvtTpl);
									obj = (T)(object)newEv;
									className = new StringID(obj.ClassCRC.Value);
								} else {
									c.SystemLogger?.LogInfo("Removing Generic component: {0}", obj.GetType());
									MakeNull();
								}
							}
						}
					}
				}
			}
			previousSettings = settings;
		}

		public void MakeNull() {
			className = null;
			obj = null;
		}
	}
}
