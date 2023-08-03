namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class InteractPropCsReq
	{
		[ProtoMember(8)] public MotionInfo Motion;
		[ProtoMember(3)] public int PropEntityId;
		[ProtoMember(1)] public int InteractId;
	}
	
}
