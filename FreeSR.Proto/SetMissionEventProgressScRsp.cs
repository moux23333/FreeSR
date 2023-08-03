namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetMissionEventProgressScRsp
	{
		[ProtoMember(2)] public int Retcode;
	}
	
}
