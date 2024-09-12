#!/bin/sh

fastlane empty_s3_bucket region:$AWS_REGION access_key_id:$AWS_ACCESS_KEY_ID secret_access_key:$AWS_SECRET_ACCESS_KEY bucket:$WEBGL_BUCKET
fastlane upload_dir_to_s3 region:$AWS_REGION access_key_id:$AWS_ACCESS_KEY_ID secret_access_key:$AWS_SECRET_ACCESS_KEY bucket:$WEBGL_BUCKET dir_to_upload:$UNITY_PLAYER_PATH
