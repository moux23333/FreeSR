namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UpdateEquipmentRarity4AutoLockScRsp
	{
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(6)] public bool NILEPOCAONC;
	}
	
}
