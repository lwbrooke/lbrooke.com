# lbrooke.com

My personal website

## Technologies

- hugo
    - hugo-theme-diary
- firebase

## First time setup

- install hugo
- install firebase cli
    - login to gcp account

## Install and run development server

- git clone https://github.com/lwbrooke/lbrooke.com
- cd lbrooke.com
- `git submodule update --remote --merge`
- `hugo serve -D`
- navigate to http://localhost:1313

## Adding a new page
- `hugo new path/to-page.md`

## Deployment

- `hugo && firebase deploy`
