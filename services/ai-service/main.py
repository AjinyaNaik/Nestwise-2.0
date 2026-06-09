from fastapi import FastAPI

app = FastAPI(
    title="NestWise AI Service",
    version="1.0.0"
)

@app.get("/")
async def root():
    return {
        "service": "NestWise AI Service",
        "status": "running"
    }

@app.get("/health")
async def health():
    return {
        "status": "healthy"
    }