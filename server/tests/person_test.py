from tests.conftest import rpc_json

async def test_get_ok():
    r = await rpc_json("person/create", firstname="Lionel", surname="Messi")
    assert r.id == 1

    r = await rpc_json("person/get", id=1)
    assert r.id == 1
