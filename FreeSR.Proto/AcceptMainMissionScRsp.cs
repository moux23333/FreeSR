namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AcceptMainMissionScRsp
	{
		[ProtoMember(11)] public int MainMissionId;
		[ProtoMember(1)] public int Retcode;
	}
	
}
