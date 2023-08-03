namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AcceptedPamMissionExpireScRsp
	{
		[ProtoMember(14)] public int MainMissionId;
		[ProtoMember(8)] public int Retcode;
	}
	
}
