namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class InteractPropScRsp
	{
		[ProtoMember(13)] public int PropState;
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(9)] public int PropEntityId;
	}
	
}
