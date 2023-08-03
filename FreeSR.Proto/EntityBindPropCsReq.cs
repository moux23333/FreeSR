namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EntityBindPropCsReq
	{
		[ProtoMember(5)] public bool IsBind;
		[ProtoMember(4)] public MotionInfo Motion;
	}
	
}
