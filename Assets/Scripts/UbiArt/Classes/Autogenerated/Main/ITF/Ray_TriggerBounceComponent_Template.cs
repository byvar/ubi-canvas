using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_TriggerBounceComponent_Template : CSerializable {
		[Serialize("phantom"                          )] public Generic<PhysShape> phantom;
		[Serialize("hurtLevel"                        )] public uint hurtLevel;
		[Serialize("bounceType"                       )] public Enum_RJR_0 bounceType;
		[Serialize("faction"                          )] public uint faction;
		[Serialize("retriggerDelay"                   )] public float retriggerDelay;
		[Serialize("idleAnim"                         )] public StringID idleAnim;
		[Serialize("bounceAnim"                       )] public StringID bounceAnim;
		[Serialize("direction"                        )] public Vector2 direction;
		[Serialize("useDirAsWorldAngle"               )] public int useDirAsWorldAngle;
		[Serialize("stickFruit"                       )] public int stickFruit;
		[Serialize("sendBounceOnHit"                  )] public int sendBounceOnHit;
		[Serialize("radial"                           )] public int radial;
		[Serialize("radialConstrained"                )] public int radialConstrained;
		[Serialize("height"                           )] public float height;
		[Serialize("height2"                          )] public float height2;
		[Serialize("speed"                            )] public float speed;
		[Serialize("multiplier"                       )] public float multiplier;
		[Serialize("offset"                           )] public Vector2 offset;
		[Serialize("detectRange"                      )] public Angle detectRange;
		[Serialize("sendMoreThanOnce"                 )] public int sendMoreThanOnce;
		[Serialize("useBounceToPickable"              )] public int useBounceToPickable;
		[Serialize("useAngleToDiscardBounceToPickable")] public int useAngleToDiscardBounceToPickable;
		[Serialize("ignoreHitLevel"                   )] public uint ignoreHitLevel;
		[Serialize("blocksHits"                       )] public int blocksHits;
		[Serialize("disableAtBounce"                  )] public int disableAtBounce;
		[Serialize("registerToAIManager"              )] public int registerToAIManager;
		[Serialize("playBounceAnimOnHit"              )] public int playBounceAnimOnHit;
		[Serialize("Generic<PhysShape>__0"            )] public Generic<PhysShape> Generic_PhysShape__0;
		[Serialize("uint__1"                          )] public uint uint__1;
		[Serialize("Enum_RFR_0__2"                    )] public Enum_RFR_0 Enum_RFR_0__2;
		[Serialize("uint__3"                          )] public uint uint__3;
		[Serialize("float__4"                         )] public float float__4;
		[Serialize("StringID__5"                      )] public StringID StringID__5;
		[Serialize("StringID__6"                      )] public StringID StringID__6;
		[Serialize("Vector2__7"                       )] public Vector2 Vector2__7;
		[Serialize("int__8"                           )] public int int__8;
		[Serialize("int__9"                           )] public int int__9;
		[Serialize("int__10"                          )] public int int__10;
		[Serialize("int__11"                          )] public int int__11;
		[Serialize("int__12"                          )] public int int__12;
		[Serialize("float__13"                        )] public float float__13;
		[Serialize("float__14"                        )] public float float__14;
		[Serialize("float__15"                        )] public float float__15;
		[Serialize("float__16"                        )] public float float__16;
		[Serialize("Vector2__17"                      )] public Vector2 Vector2__17;
		[Serialize("Angle__18"                        )] public Angle Angle__18;
		[Serialize("int__19"                          )] public int int__19;
		[Serialize("int__20"                          )] public int int__20;
		[Serialize("int__21"                          )] public int int__21;
		[Serialize("uint__22"                         )] public uint uint__22;
		[Serialize("int__23"                          )] public int int__23;
		[Serialize("int__24"                          )] public int int__24;
		[Serialize("int__25"                          )] public int int__25;
		[Serialize("int__26"                          )] public int int__26;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(Generic_PhysShape__0));
				SerializeField(s, nameof(uint__1));
				SerializeField(s, nameof(Enum_RFR_0__2));
				SerializeField(s, nameof(uint__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(StringID__5));
				SerializeField(s, nameof(StringID__6));
				SerializeField(s, nameof(Vector2__7));
				SerializeField(s, nameof(int__8));
				SerializeField(s, nameof(int__9));
				SerializeField(s, nameof(int__10));
				SerializeField(s, nameof(int__11));
				SerializeField(s, nameof(int__12));
				SerializeField(s, nameof(float__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(float__15));
				SerializeField(s, nameof(float__16));
				SerializeField(s, nameof(Vector2__17));
				SerializeField(s, nameof(Angle__18));
				SerializeField(s, nameof(int__19));
				SerializeField(s, nameof(int__20));
				SerializeField(s, nameof(int__21));
				SerializeField(s, nameof(uint__22));
				SerializeField(s, nameof(int__23));
				SerializeField(s, nameof(int__24));
				SerializeField(s, nameof(int__25));
				SerializeField(s, nameof(int__26));
			} else {
				SerializeField(s, nameof(phantom));
				SerializeField(s, nameof(hurtLevel));
				SerializeField(s, nameof(bounceType));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(retriggerDelay));
				SerializeField(s, nameof(idleAnim));
				SerializeField(s, nameof(bounceAnim));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(useDirAsWorldAngle));
				SerializeField(s, nameof(stickFruit));
				SerializeField(s, nameof(sendBounceOnHit));
				SerializeField(s, nameof(radial));
				SerializeField(s, nameof(radialConstrained));
				SerializeField(s, nameof(height));
				SerializeField(s, nameof(height2));
				SerializeField(s, nameof(speed));
				SerializeField(s, nameof(multiplier));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(detectRange));
				SerializeField(s, nameof(sendMoreThanOnce));
				SerializeField(s, nameof(useBounceToPickable));
				SerializeField(s, nameof(useAngleToDiscardBounceToPickable));
				SerializeField(s, nameof(ignoreHitLevel));
				SerializeField(s, nameof(blocksHits));
				SerializeField(s, nameof(disableAtBounce));
				SerializeField(s, nameof(registerToAIManager));
				SerializeField(s, nameof(playBounceAnimOnHit));
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x21368B71;
	}
}

