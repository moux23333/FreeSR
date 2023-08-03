namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EntityMotion
	{
		[ProtoMember(5)] public int MapLayer;
		[ProtoMember(14)] public MotionInfo Motion;
		[ProtoMember(6)] public int EntityId;
	}
	
}
