import asyncio
import os
from pathlib import Path
from typing import Any, Iterable
import httpx
import pytest
import subprocess

URL = "http://localhost:3000/rpc"

@pytest.fixture(scope="session", autouse=True)
async def autouse_session():
    process = subprocess.Popen(
        "dotnet.exe build -o bin",
        stdout=subprocess.DEVNULL,
        stderr=subprocess.DEVNULL,
    )
    process.wait()
    assert process.returncode == 0

@pytest.fixture(scope="function", autouse=True)
async def autouse_function():
    process = subprocess.Popen(
        str(Path(Path.cwd(), "bin/gfa.exe")),
        stdout=subprocess.DEVNULL,
        stderr=subprocess.DEVNULL,
    )
    yield
    process.terminate()

async def rpc_json(target: str, **body_kwargs) -> Any:
    r = await httpx.AsyncClient().post(URL + "/" + target, json=body_kwargs)
    assert r.status_code in [200, 400]
    return r.json()
