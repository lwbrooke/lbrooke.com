#!/usr/bin/env python3
# -*- coding: utf-8 -*- #
from __future__ import unicode_literals

AUTHOR = 'Logan Brooke'
SITENAME = 'lbrooke.com'
SITEURL = ''

PATH = 'content'

TIMEZONE = 'America/Los_Angeles'

DEFAULT_LANG = 'en'

# Feed generation is usually not desired when developing
FEED_ALL_ATOM = None
CATEGORY_FEED_ATOM = None
TRANSLATION_FEED_ATOM = None
AUTHOR_FEED_ATOM = None
AUTHOR_FEED_RSS = None

# Blogroll
LINKS = (
    ('Contact', '/pages/contact'),
    ('Resume', '/pages/resume'),
)

# Social widget
SOCIAL = (
    ('Facebook', 'https://www.facebook.com/logan.brooke.3'),
    ('GitHub', 'https://github.com/lwbrooke'),
    ('LinkedIn', 'https://www.linkedin.com/in/loganwbrooke'),
    ('Twitter', 'https://twitter.com/treebeard_ls'),
)

# GitHub ribbon
GITHUB_URL = 'https://github.com/lwbrooke'

DEFAULT_PAGINATION = 10

STATIC_PATHS = [
    'extra/favicon.ico',
    'images'
]

EXTRA_PATH_METADATA = {
    'extra/favicon.ico': {'path': 'favicon.ico'}
}

# Uncomment following line if you want document-relative URLs when developing
# RELATIVE_URLS = True
